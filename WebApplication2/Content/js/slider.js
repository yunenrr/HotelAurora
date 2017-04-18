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


$(function(){
	var SliderModule = (function(){
		var pb = {};
		pb.el = $('#slider');
		pb.items = {
			panel: pb.el.find('li')
		}

		//variables necesarias
		var sliderInterval, currentSlider = 0,
			nextSlider = 1,
			lengthSlider = pb.items.panel.length;

		//Inicialize
		pb.init = function(settings){
			//activamos nuestro slider
			SliderInit();

			//controles slider
			$('#slider-controls').on('click', 'li', function(e){
				var $this = $(this);

				if (currentSlider !==  $this.index()) {
					changePanel($this.index());
				}
				
			})


		}

		var SliderInit = function(){
			sliderInterval = setInterval(pb.startSlider, 4000);
		}

		pb.startSlider = function(){

			var panels = pb.items.panel,
			    controls = $('#slider-controls li');

			if (nextSlider >= lengthSlider) {
				nextSlider = 0;
				currentSlider = lengthSlider-1;
			}

			//efectos
			controls.removeClass('active').eq(currentSlider).addClass('active');
			panels.eq(currentSlider).fadeOut('slow');
			panels.eq(nextSlider).fadeIn('slow');
			

			//Actualizamos nbuestro datos
			currentSlider = nextSlider;
			nextSlider +=1;
		}

		//function para controladore sde slider
		var changePanel = function(id){

			clearInterval(sliderInterval);
			var panels = pb.items.panel,
				controls = $('#slider-controls li');
			//comprabamos el ID
			if (id >= lengthSlider) {
				id = 0;
			}else if (id <0) {
				id = lengthSlider-1;
			}

			//Efectos
			//efectos
			controls.removeClass('active').eq(id).addClass('active');
			panels.eq(currentSlider).fadeOut('slow');
			panels.eq(id).fadeIn('slow');

			//actualizar nuestros datos
			currentSlider = id;
			nextSlider = id + 1;

			//reactivar slider
			SliderInit();

		}

		return pb;
	}());

	SliderModule.init();
});