var x= 1;
function exalerta(){
    if( x >= 5 ){
        document.getElementById("botao").disabled= true;
        
    }
    alert("Contador: "+x);
    x++;
}

