/*$(document).ready(function(){
  $(".btnResgate").click(function(){
    $("#conteudo-modal").load("@Url.Action("Resgatar","Recompensa")",
    function(response){
      $("#conteudo-modal").modal("show"),response;
    });
    //
    
  });
});
*/
function abrirModalCodigo(id){
  //alert(id);
  $.ajax({
     url: "@Url.Action("Resgatar","Recompensa")"  ,
    success: function (retorno) {
        alert(retorno);
        $("#conteudo-modal").modal("show")
    }
});
}

/*$(document).ready(function(){
  $(".btnResgate").click(function(){

      var id = $(this).data("value");

      $.ajax({
        type:"GET",
        url: "http://reciganha.somee.com/API/Recompensa/" + id,
        dataType: 'json',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Access-Control-Allow-Origin': '*',
            'Access-Control-Allow-Credentials': 'true',
            'Access-Control-Allow-Headers':'origin, content-type, accept, authorization',
            'Access-Control-Allow-Methods':'GET, POST, PUT, DELETE, OPTIONS, HEAD'
        },
      }).done(function(code) {
        alert("Código" + code)
      });
  });
});
*/
 /*$(document).ready(function(){
            $(".btnResgate").click(function(){

                var id = $(this).data("value");

                $("#conteudo-modal").load("http://reciganha.somee.com/API/Recompensa/Resgatar/" + id, 
                function(response){
                    alert("codigo " + response);
                    //$("#modal-mensagem").modal("show");
                });
            });
        }); 
*/
