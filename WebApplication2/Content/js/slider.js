//almacenar sliderDa en una variable
var sliderDa = $('#sliderDa');
//almacenar botones
var siguiente = $('#btn-next');
var anterior = $('#btn-prev');

//mover ultima imagen al primer lugar
$('#sliderDa .slider__sectionDa:last').insertBefore('#sliderDa .slider__sectionDa:first');
//mostrar la primera imagen con un margen de -100%
sliderDa.css('margin-left', '-'+100+'%');

function moverD() {
	sliderDa.animate({
		marginLeft:'-'+250+'%'
	} ,700, function(){
		$('#sliderDa .slider__sectionDa:first').insertAfter('#sliderDa .slider__sectionDa:last');
		sliderDa.css('margin-left', '-'+100+'%');
	});
}

function moverI() {
	sliderDa.animate({
		marginLeft:0
	} ,700, function(){
		$('#sliderDa .slider__sectionDa:last').insertBefore('#sliderDa .slider__sectionDa:first');
		sliderDa.css('margin-left', '-'+100+'%');
	});
}

function autoplay() {
	interval = setInterval(function(){
		moverD();
	}, 5000);
}
siguiente.on('click',function() {
	moverD();
	clearInterval(interval);
	autoplay();
});

anterior.on('click',function() {
	moverI();
	clearInterval(interval);
	autoplay();
});


autoplay();


