import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Observable, throwError} from "rxjs";
import { retry, catchError } from "rxjs/operators";
import { Pessoa } from '../models/pessoa';

@Injectable({
  providedIn: 'root'
})
export class PessoaService {
  url= 'https://localhost:7153/api/pessoas';
  constructor(private httpClient: HttpClient){ }

  httpOptions= {
    headers: new HttpHeaders({'Content-Type': 'application/json'})
  }

  getPessoas(): Observable<Pessoa[]> {
    return this.httpClient.get<Pessoa[]>(this.url)
    .pipe(
      retry(2),
      catchError(this.handleError))
  }

  getPessoaById(id: number): Observable<Pessoa> {
    return this.httpClient.get<Pessoa>(this.url + '/' + id).pipe(
      retry(2),
      catchError(this.handleError)
    )
  }

  savePessoa(pessoa: Pessoa) : Observable<Pessoa>{
    console.log(this.url, JSON.stringify(pessoa));
    return this.httpClient.post<Pessoa>(this.url, JSON.stringify(pessoa),this.httpOptions).pipe(
      retry(2), 
      catchError(this.handleError))
  }

  updatePessoa(pessoa: Pessoa): Observable<Pessoa>{
    return this.httpClient.put<Pessoa>(this.url + '/' + pessoa.id, JSON.stringify(pessoa),
    this.httpOptions).pipe(
      retry(1),
      catchError(this.handleError)
    )
  }

  deletePessoa(pessoa: Pessoa){
    return this.httpClient.delete<Pessoa>(this.url + '/' + pessoa.id).pipe(
      retry(1),
      catchError(this.handleError)
    )
  }

  addPessoa(pessoa: Pessoa){
    console.log(this.url, JSON.stringify(pessoa));
    return this.httpClient.post<Pessoa>(this.url, JSON.stringify(pessoa))
      .pipe(
        retry(2),
        catchError(this.handleError)
      )
  }

  handleError(error: HttpErrorResponse): Observable<never> {
    let errorMessage= '';
    if(error.error instanceof ErrorEvent){
      errorMessage= error.error.message;
    }
    else{
      errorMessage = 'Código do erro: ${error.status}, '+
      'mensagem: ${error.message}';
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }

}
