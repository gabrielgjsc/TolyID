function mostraSenha(){
        var inputPass = document.getElementById('inputsenha')
        var btnShowPass = document.getElementById('btn-senha')

    if(inputPass.type === 'password'){
        inputPass.setAttribute('type', 'text')
        btnShowPass.classList.replace('bi-eye', 'bi-eye-slash')
}
    else{
        inputPass.setAttribute('type', 'password')
        btnShowPass.classList.replace('bi-eye-slash', 'bi-eye')
        }
}

function mostraSenhainsc(){
    var inputPass = document.getElementById('inputsenhainsc')
    var btnShowPass = document.getElementById('btn-senhainsc')

if(inputPass.type === 'password'){
    inputPass.setAttribute('type', 'text')
    btnShowPass.classList.replace('bi-eye', 'bi-eye-slash')
}
else{
    inputPass.setAttribute('type', 'password')
    btnShowPass.classList.replace('bi-eye-slash', 'bi-eye')
    }
}

function tiraHifen(telefone) {
    const textoAtual = telefone.value;
    const textoAjustado = textoAtual.replace(/[-()]/g, '');

    telefone.value = textoAjustado;
}

function mascaraDeTelefone(telefone){
    const textoAtualInit = telefone.value;
    textoAtual = textoAtualInit.replace(/[^\d()-]/g, '');
    const isFixo = textoAtual.length === 10;
    const isCelular = textoAtual.length === 11;
    const isCelularNoDDD = textoAtual.length === 9;
    const isFixoNoDDD = textoAtual.length === 8;
let textoAjustado;
    if(isFixo) {
        const parte1 = textoAtual.slice(0,2);
        const parte2 = textoAtual.slice(2,6);
        const parte3 = textoAtual.slice(6,10);
        textoAjustado = `(${parte1})${parte2}-${parte3}`        
    } else if(isCelular){
        const parte1 = textoAtual.slice(0,2);
        const parte2 = textoAtual.slice(2,7);
        const parte3 = textoAtual.slice(7,14);
        textoAjustado = `(${parte1})${parte2}-${parte3}`  
    }
    else if(isCelularNoDDD){
        const parte1 = textoAtual.slice(0,5);
        const parte2 = textoAtual.slice(5,9);
        textoAjustado = `()${parte1}-${parte2}`
    }
    else if(isFixoNoDDD){
        const parte1 = textoAtual.slice(0,4);
        const parte2 = textoAtual.slice(4,8);
        textoAjustado = `()${parte1}-${parte2}`
    }
 else {
    textoAjustado = textoAtual; 
}
    telefone.value = textoAjustado;
}
