
window.onload = function(){
  fetch('http://localhost:5000/TipoMaterial',{
    "mode": "no-cors",
    "method": "GET"
  }).then(data => {
    return data.json();
  }).then(Response => {
    console.log(Response);
  })
}







/*$(document).ready(function(){
    $.ajax({
        "url": "http://charlenefialho.somee.com/ReciGanha/TipoMaterial",
        "method": "GET",
        "timeout": 0,
    }).done(function (resposta){
        adicionarCardsMaterial(resposta);
    });
});
*/
function adicionarCardsMaterial(materiais){
    let section = document.getElementsByClassName("cards");

    materiais.forEach((element) => {
        let card = document.createElement("div").innerHTML;

        card.classList.add("card");
        card.innerHTML = '<img src="assets/img/metal.jpg" class="card-img-top " alt="latinhas de refrigerante"/>'
        '<div class="card-body">'
          '<h5 class="card-title text-dark">Aluminio</h5>'
          '<select>'
            '<option value="' + element.idTipoMaterial +'">'
              + element.nomeMaterial +
            '</option>'
          '</select>'
          '<span>Insira o peso em Kg</span>'
          '@Html.TextBoxFor(model => model.'+ element.nomeMaterial +', new { htmlAttributes = new { @class = "form-control" } })';

          section.appendChild(card)
    });
}
