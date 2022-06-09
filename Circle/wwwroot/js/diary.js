"use strict";
$(document).ready(function() {
    
    let $deleteButton = $('.delete-button');

    $deleteButton.on('click', function () {
        let $this = $(this);
        let diaryIdVal = $this.attr('id');

        $.ajax({
            type: "DELETE",
            url: '/diary/delete',
            data: {
                diaryId: diaryIdVal,
            },
        }).done(function (response) {
            var $thisCard = $this.closest('.card-container')
            $thisCard.remove();

        }).fail(function (error) {
            console.log(error.message);
        });
    })

});