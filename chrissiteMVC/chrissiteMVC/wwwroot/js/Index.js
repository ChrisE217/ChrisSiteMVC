$(document).ready(function () {
    $('.fade-in').fadeIn(3000).removeClass('hidden');
});

function contacts() {
    hideAll();
    $('.contacts-group').fadeIn('fast').removeClass('hidden');
}

function about() {
    hideAll();
    $('.about-group').fadeIn('fast').removeClass('hidden');
}

function otherLinks() {
    hideAll();
    $('.other-links-group').fadeIn('fast').removeClass('hidden');
}

function hideAll() {
    $('.contacts-group').hide().addClass('hidden');
    $('.other-links-group').hide().addClass('hidden');
    $('.about-group').hide().addClass('hidden');
}

