function scaleToFill() {
    $('video.video-background').each(function (index, videoTag) {
        var $video = $(videoTag),
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
    $('.player').click(function () {
        let video = $('.video1').get(0);
        if (video.paused) {
            video.play();
        } else {
            video.pause();
        }        
    });
    $('.video-background').on('loadeddata', scaleToFill);

    $(window).resize(function () {
        scaleToFill();
    });
});