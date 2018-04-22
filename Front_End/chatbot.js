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

    var directLine = new DirectLine.DirectLine({
        secret: 'PIV3Z3IYErI.cwA.tp0.IT1K4ZhBN2UQjMrUVGHj9qcLxHfOkaqxnoIEYCgVq8I' });

    directLine.activity$
    .filter(activity => activity.type === 'message')
    .subscribe(
        message => console.log("received message ", message)
    );


    $(".chat-input__text").keypress(function (event) { // Send message to the chat bot
        //  &&  document.getElementById(".chat-input__text").value != "" use for null
        if (event.which == 13) {

            event.preventDefault();
            var userMessage = $(".chat-input__text").val();

            var prevState = $(".chat-logs").html();


            directLine.postActivity({
                from: { id: 'User', name: 'User' }, // required (from.name is optional)
                type: 'message',
                text: userMessage,
            }).subscribe(
                id => console.log("Posted activity, assigned ID ", id),
                error => console.log("Error posting activity", error)
            );

            $(".chat-logs").html(prevState + "<br>" + "<div class=\"chat-user\">" + userMessage + "</div>");

            // Send the request to server
            // Server returns the response, and is passed into robot message
            // Below the bot message passes in a placeholder



            $(".chat-input__text").val("");

            setTimeout(function () {
                var prevState = $(".chat-logs").html();
                var placeholder = "Oi, I'm a placeholder";

                $(".chat-logs").html(prevState + "<br>" + "<div><img class=\"msg-avatar\" src=\"STU.jpg\"/><div class=\"chat-bot\">" + placeholder + "</div></div>");
            }, 750);




        }
    })




})