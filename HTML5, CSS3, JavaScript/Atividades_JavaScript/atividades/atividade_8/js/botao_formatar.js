function aumentarFont(){
   $("p").css({'fontSize':'40px'})
}

function diminuirFont(){
    $("p").css({'fontSize':'5px'})
}

function normalFont(){
    $("p").css({'fontSize':'17px'})
}

function pintarPreto(){
    $(".texto").css({'background-color':'#000000'})
}

function pintarBranco(){
    $(".texto").css({'background-color':'#ffffff'})
}

function pintarTextoBranco(){
    $(".texto").css({'color':'#ffffff'})
}

function pintarTextoPreto(){
    $(".texto").css({'color':'#000000'})
}

function caixaAlta(){
    document.getElementById("texto").style.textTransform = "uppercase";
}

function caixaBaixa(){
    document.getElementById("texto").style.textTransform = "lowercase";
}

