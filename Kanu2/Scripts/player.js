let video;
let playButton;
let pauseButton;
let hoverControls;
let overlayControls;
let player;

function scaleToFill() {
    $('video.video-background').each(function (index, videoTag) {
        let $video = $(videoTag),
            videoRatio = videoTag.videoWidth / videoTag.videoHeight,
            tagRatio = $video.width() / $video.height(),
            val;
        if (videoRatio < tagRatio) {
            val = tagRatio / videoRatio * 1.02;
        } else if (tagRatio < videoRatio) {
            val = videoRatio / tagRatio * 1.02;
        }
        $video.css('transform', 'scale(' + val + ',' + val + ')');
    });
}

$(function () {
    scaleToFill();
    video = $('.video1').get(0);
    playButton = $('.play');
    pauseButton = $('.pause');
    hoverControls = $('.hover'); 
    player = $('.player');        
    player.one('click', () => {
        fadeInHoverControls();
        player.hover(function () {
            fadeInHoverControls();
        });
        //todo replace with center of player something like that
        player.mouseLeave(function () {
            fadeOutHoverControls();
        })
    });
    player.click(videoToggle);
    playButton.click(play);
    pauseButton.click(pause);
    $('.video-background').on('loadeddata', scaleToFill);
    $(window).resize(function () {
        scaleToFill();
    });        
});

function videoToggle() {    
    if (video.paused) {
        play();    
    } else {
        pause();
    }
}

function pause() {    
    video.pause();
    playButton.css('display', 'inline');
    pauseButton.css('display', 'none');
}

function play() {    
    video.play();
    pauseButton.css('display', 'inline');
    playButton.css('display', 'none');
}

function fadeInHoverControls() { 
    hoverControls.each((index) => {
        $(hoverControls.get(index)).fadeIn();        
    });    
    if (video.paused) {
        pauseButton.css('display', 'none');
    } else {
        playButton.css('display', 'none');
    }
}

function fadeOutHoverControls() {
    hoverControls.each((index) => {
        $(hoverControls.get(index)).fadeOut();        
    });     
    if (video.paused) {
        pauseButton.css('display', 'none');
    } else {
        playButton.css('display', 'none');
    }
}
