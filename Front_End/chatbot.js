//calls code in html
$(function () {
    
   // $(".chat-box").show('scale');
   // $(".chat-box-welcome__header").show('scale');
   // $(".chat-circle").show('scale');
    
    /*Animations from click events*/

    $(".chat-circle").click(function () {
        $(".chat-circle").hide('scale');
        $(".chat-box").show('scale');
        $(".chat-box-welcome__header").show('scale');
    })
    
    $(".chat-box-toggle").click(function () {
        $(".chat-circle").show('scale');
        $(".chat-box").hide('scale');
        $(".chat-box-welcome__header").hide('scale');
        $("#chat-box__wraper").hide('scale');
    })
    
    $(".chat-input__text").click(function () {
        $(".chat-box-welcome__header").hide();
        $("#chat-box__wraper").show();
    })

    
    $(".chat-input__text").keypress(function(event) { // Send message to chat bot
        //  &&  document.getElementById(".chat-input__text").value != "" use for null
        if (event.which == 13) {
            
            console.log("enter pressed, checkbox is checked");
            event.preventDefault();
            $(".chat-input__text").val("");

        } 
    }) 

})