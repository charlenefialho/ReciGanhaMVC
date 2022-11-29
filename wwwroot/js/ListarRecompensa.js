$(document).ready(function(){
  $(".btnResgate").click(function(){

    $("#modal-mensagem").modal("show");
    /*window.onload = function(){
       
      }*/
    
  });
});


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
/* $(document).ready(function(){
            $(".btnResgate").click(function(){

                var id = $(this).data("value");

                $("#conteudo-modal").load("http://reciganha.somee.com/API/Recompensa/Resgatar/" + id, 
                function(response){
                    alert("codigo" + response);
                    //$("#modal-mensagem").modal("show");
                });
            });
        }); */




/*function resgatarRecompensa(id_clicked){

    let id = id_clicked.toString();

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

     // $("#modal-mensagem").modal();
};
*/
