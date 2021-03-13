function getID(id){
    return document.getElementById(id).value;
}
function innerHTML(id, result){
    return document.getElementById(id).innerHTML=result;
}
function contadorCaracteres(){
    setInterval(function(){
        var c = getID("txt");
        if (c.length > 50) {
            innerHTML("txtVista", "")
        }else{
            innerHTML("txtVista", c.length);
        }
    },0000);
}
