document.body.setAttribute('data-tema', 't-claro');
  

const button= document.querySelector('.js-tema');

const temas ={
    't-escuro' : 't-claro',
    't-claro' : 't-escuro',
}
    if(button){
        button.addEventListener('click', event=> {
            event.preventDefault()
            const tema= document.body.dataset.tema
            document.body.setAttribute('data-tema', temas[tema] || 't-claro')
        })
    }
