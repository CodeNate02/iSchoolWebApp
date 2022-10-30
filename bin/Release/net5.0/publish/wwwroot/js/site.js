// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

/*const M = require("minimatch");*/

// Write your JavaScript code.
$(document).ready(function () {
    //Set element after quote to always margin its way under it
    $('.quote + *').css('margin-top', $('.quote').outerHeight()+25);

    var gSlick = null;

    $(".tabs").tabs();
    //Academics Triggers
    $('#underGrad .degrees').slick();
    $(".ui-tabs-nav").click(function () {
        if (gSlick == null) {
            gSlick = $('#graduate .degrees').slick();
        }

    });
    $('.minorButton').magnificPopup({
        type: 'inline',
        delegate: 'a',
        gallery: {
            enabled: true
        }
    });
    $('.minorCourse').tooltip({

    });

    $('.tableButton').magnificPopup({
        type: 'inline',
        gallery: {
            enabled: true
        }
    });

    //FacultyStaff Triggers
    //Careers Triggers
    $('#empTable table').DataTable();
    $('#coopTable table').DataTable();

    $('#faculty').magnificPopup({
        type: 'inline',
        delegate: 'div'
    });
    $('#staff').magnificPopup({
        type: 'inline',
        delegate: 'div'
    });
    
});
$(window).on('resize', function () {
    //Set element after quote to always margin its way under it
    $('.quote + *').css('margin-top', $('.quote').outerHeight()+25);
})