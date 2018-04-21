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

    
    $(".chat-input__text").keypress(function(event) { // Send message to the chat bot
        //  &&  document.getElementById(".chat-input__text").value != "" use for null
        if (event.which == 13) { 
            event.preventDefault();
            var userMessage = $(".chat-input__text").val();
            var prevState =  $(".chat-logs").html();
            $(".chat-logs").html(prevState + "<br>" + "<div class=\"chat-user\">" + userMessage + "</div>");
            $(".chat-input__text").val("");


            // Send the request to server
            // Server returns the response, and is passed into robot message
            // Below the bot message passes in a placeholder
            // Needs to input content and it's content type

            setTimeout(function() {
                var prevState = $(".chat-logs").html();
                var content = "Oi, I'm a placeholder";
                //var content = "maxresdefault.jpg";
                var contentType = "string"
                if (contentType == "string") {
                    $(".chat-logs").html(prevState + "<br>" + "<div><img class=\"msg-avatar\" src=\"STU icon.png\"/><div class=\"chat-bot\">" + content + "</div></div>");

                } else {
                    $(".chat-logs").html(prevState + "<br>" + "<div><img class=\"msg-avatar\" src=\"STU icon.png\"/><div class=\"chat-bot\">" + "<image class=\"img\" src=\"" + content + "\"/>" + "</div></div>");

                }
                
                //$(".chat-logs").html(prevState + "<br>" + "<div><img class=\"msg-avatar\" src=\"STU icon.png\"/><div class=\"chat-bot\">" + placeholder + "</div></div>");
            }, 750);
           



        } 
    }) 

    

})