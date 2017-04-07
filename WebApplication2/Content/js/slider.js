//almacenar sliderDa en una variable
var sliderDa = $('#sliderDa');

//almacenar botones
var siguiente = $('#btn-next');
var anterior = $('#btn-prev');


//mpver ultima imagen al primer lugar
$('#sliderDa section:last').insertBefore('#sliderDa section:first');

//mostrar la primera imagen con un margen de -100%
sliderDa.css('margin-left', '-'+10+'%');


function moverD(){
	sliderDa.animate({
		marginLeft: '-'+20+'%'}, 700, function(){

			$('#sliderDa section:first').insertAfter('#sliderDa section:last');
			sliderDa.css('margin-left', '-'+10+'%');

		} );
}

function moverI(){
	sliderDa.animate({
		marginLeft: '-'+20+'%'}, 700, function(){

			$('#sliderDa section:last').insertAfter('#sliderDa section:first');
			sliderDa.css('margin-left', '-'+10+'%');

		} );
}

siguiente.on('click', function() {
	moverD();
});

anterior.on('click', function() {
	moverI();
});

function autoplay(){
	interval = setInterval(function(){
		moverD();
	}, 8000);
}

autoplay();