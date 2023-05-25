var script = document.createElement('script');
script.src = 'https://code.jquery.com/jquery-3.6.3.min.js';
document.getElementsByTagName('head')[0].appendChild(script);
$('#anim1:eq(0)').fadeIn(300, function(){
    $(this).next().fadeIn(300, arguments.callee);
});