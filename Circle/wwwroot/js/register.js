"use strict";
$(document).ready(function() {
    // js.init = function () {


        let $usernameInput = $('#register-username-input');
        let $firstNameInput = $('#register-firstName-input');
        let $lastNameInput = $('#register-lastName-input');
        let $passwordInput = $('#register-password-input');
        let $confirmPasswordInput = $('#register-confirm-password-input');
        let $registerButton = $('#register-button');
        let $allInputs = $('.shared-input-field');
        var token = $('input[name="__RequestVerificationToken"]').val();

        $registerButton.on('click', function () {

            let $usernameVal = $usernameInput.val().trim();
            let $firstNameVal = $firstNameInput.val().trim();
            let $lastNameVal = $lastNameInput.val().trim();
            let $passwordVal = $passwordInput.val().trim();
            let $confirmPasswordVal = $confirmPasswordInput.val().trim();

            $.ajax({
                type: "POST",
                url: '/register/init',
                data: {
                    __RequestVerificationToken: token,
                    Username: $usernameVal,
                    FirstName: $firstNameVal,
                    LastName: $lastNameVal,
                    Password: $passwordVal,
                    confirmPassword: $confirmPasswordVal
                },
            }).done(function (response) {
                console.log(response.message)
                $allInputs.val('');

            }).fail(function (error) {
                console.log(error.message);
            });

        });
        

    // }
});