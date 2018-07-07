// Write your JavaScript code.
var x = 1;

function AgregarSintoma(Sintomas) {
    console.log(Sintomas);
    var div = document.getElementById("SintomasListDiv");
    div.innerHTML += '<div class="form-group col-md-3"><label asp-for="SintomaID" id="[' + x +'].SintomaID"> Sintoma: </label>' +
        '<select class ="form-control" selected="Elija una opcion" name="sintomas">' + GetItems(Sintomas) +
        '</select><span asp-validation-for="SintomaID"></span></div>';
    x++;
}
function GetItems(Sintomas) {
    let items = "";
    for (var i = 0; i < Sintomas.length; i++) {
        items += '<option value="' + Sintomas[i].sintomaID + '">' + Sintomas[i].descripcion + '</option>';
    }
    return items;
}