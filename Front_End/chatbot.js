//calls code in html
$(function () {
    
    // $(".chat-box").show('scale');
    // $(".chat-box-welcome__header").show('scale');
    // $(".chat-circle").show('scale');
     
     /*Animations from click events*/
 
     var directLine = new DirectLine.DirectLine({
        secret: 'PIV3Z3IYErI.cwA.tp0.IT1K4ZhBN2UQjMrUVGHj9qcLxHfOkaqxnoIEYCgVq8I' });

 
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

     directLine.activity$
     .filter(activity => activity.type === 'message' && activity.from.id === 'UTSSTU').subscribe(
         message => {
              console.log("received message ", message);
              var prevState = $(".chat-logs").html();
              
              $(".chat-logs").html(prevState + "<br>" + "<div><img class=\"msg-avatar\" src=\"STU.jpg\"/><div class=\"chat-bot\">" + message.text + "</div></div>");  

             var d = $('.chat-logs');
             d.scrollTop(d.prop("scrollHeight"));

         }); 
     
     $(".chat-input__text").keypress(function(event) { 
         if (event.which == 13) {
             
             event.preventDefault();
             var userMessage = $(".chat-input__text").val();
 
             var prevState =  $(".chat-logs").html();
 
             directLine.postActivity({
                from: { id: 'userId', name: 'User' }, 
                type: 'message',
                text: userMessage
            }).subscribe(
                id => console.log("Posted activity, assigned ID ", id),
                error => console.log("Error posting activity", error)
            );

             $(".chat-logs").html(prevState + "<br>" + "<div class=\"chat-user\">" + userMessage + "</div>");
            
             $(".chat-input__text").val("");

             var d = $('.chat-logs');
             d.scrollTop(d.prop("scrollHeight"));
         } 
     }) 
 
     
 
 })