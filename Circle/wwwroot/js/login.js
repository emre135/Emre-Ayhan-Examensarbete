"use strict";
$(document).ready(function() {
    // js.init = function () {


        let $usernameInput = $('#login-username-input');
        let $passwordInput = $('#login-password-input');
        let $loginButton = $('#login-button');
        let $allInputs = $('.shared-input-field');

        $loginButton.on('click', function () {
            let $usernameVal = $usernameInput.val().trim();
            let $passwordVal = $passwordInput.val().trim();
            console.log("login button clicked...");
            $.ajax({
                type: "POST",
                url: '/login/init',
                data: {
                    username: $usernameVal,
                    password: $passwordVal
                },
            }).done(function () {
                window.location.replace("home");
            }).fail(function (error) {
                // $('.error-container').prop('hidden', false);
                // $('.error-text').text(xhr);
                console.log(error);
                
                
            })
        });
        
        $allInputs.on('keydown', function () {
            $('.error-container').prop('hidden', true);
            $('.error-text').val('');
        })
        
        
        
        // $logoutButton.on('click', function () {
        //     window.location.replace('/login');
        // });
    // }
});