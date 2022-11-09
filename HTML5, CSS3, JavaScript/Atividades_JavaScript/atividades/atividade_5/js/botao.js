function ocultar(){
    
    var check1= document.getElementById('aviao');
    var check2= document.getElementById('trem');;
    var check3= document.getElementById('onibus');;

    if ((check1.checked && check2.checked)||(check2.checked && check3.checked) || (check3.checked && check1.checked)){
        document.getElementById("botao").style.display = "inline-block"; 
    }   
    else {
        document.getElementById("botao").style.display = "none"; 
    }
}

