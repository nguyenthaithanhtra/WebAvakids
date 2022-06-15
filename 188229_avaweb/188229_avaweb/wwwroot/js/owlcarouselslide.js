$('.slider').on('initialized.owl.carousel changed.owl.carousel', function (e) {
    if (!e.namespace) {
        return;
    }
    var carousel = e.relatedTarget;
    $('.slider-counter').text(carousel.relative(carousel.current()) + 1 + '|' + carousel.items().length);
})
$('.owl-product').owlCarousel({
    loop: false,
    margin: 50,
    nav: true,
    navText: ["<i class='bi bi-chevron-left'></i>", "<i class='bi bi-chevron-right'></i>"],
    items: 1,
    dots: true,
    dotsData: true
})

$('.owl-dot').click(function () {
    $('.owl-dot').trigger('to.owl.carousel', [$(this).index(), 300]);
})

$('.owl-header').owlCarousel({
    loop: true,
    margin: 0,
    nav: false,
    items: 1,
    dots: false
})