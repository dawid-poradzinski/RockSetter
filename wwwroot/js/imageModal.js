let loaded = false;

function openImageModal() {
    $('#imageModal').modal('show');
    if (!loaded) {
        loadImages();
        loaded = true;
    }
}

function closeImageModal() {
    $('#imageModal').modal('hide');
}

function favoribleClick() {
    const heartIcon = $('#heart-icon');
    const favoribleInput = $('#favoribleInput');
    if (heartIcon.css('fill') === 'rgb(255, 0, 0)') {
        heartIcon.css('fill', 'currentColor');
        favoribleInput.val('false');
    } else {
        heartIcon.css('fill', 'red');
        favoribleInput.val('true');
    }
}