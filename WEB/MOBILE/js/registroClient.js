function habilita()
{
var estadoActual = document.getElementById("carne");
var estadoActual1 = document.getElementById("universidad");

if(estadoActual.disabled)
{
estadoActual.disabled= false;
estadoActual1.disabled= false;

}
else
{
estadoActual.disabled= true;
estadoActual1.disabled= true;
}
}

