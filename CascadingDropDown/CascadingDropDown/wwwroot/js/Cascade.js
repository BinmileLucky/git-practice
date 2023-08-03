$(document).ready(fucntion() {
    alert('ok');
});


fucntion GetCountry() {
    $.ajax({
        url: '/Second/Country',
        success: function (result) {
            $.each(result, function (i, data) {
                $('#country').append('<Option value=' + data.id + ' >' + data.name + '</Option>');
            });
        }

    });
}