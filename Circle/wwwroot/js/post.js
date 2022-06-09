"use strict";
$(document).ready(function() {
    

    let $titleInput = $('#title-input');
    let $textInput = $('#text-input');
    let $postButton = $('#post-button');
    var token = $('input[name="__RequestVerificationToken"]').val();
    
    $postButton.on('click', function () {
        let titleVal = $titleInput.val().trim();
        let textVal = $textInput.val().trim();
        
        $.ajax({
            type: "POST",
            url: '/post/add',
            data: {
                __RequestVerificationToken: token,
                title: titleVal,
                text: textVal,
            },
        }).done(function (response) {
            console.log(response.message)
            $titleInput.val('');
            $textInput.val('');

        }).fail(function (error) {
            console.log(error.message);
        });
    })

});