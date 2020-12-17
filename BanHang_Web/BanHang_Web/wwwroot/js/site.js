$(document).ready(function () {
    $('#showLogin').click(function () {
        showLogin();
        $('.super_container').fadeTo('slow', 0.2);
    });

    $('#close_login').click(function () {
        closeLogin();
        $('.super_container').fadeTo('slow', 1);
    });

    $('#showRegister').click(function () {
        showRegister();
        $('.super_container').fadeTo('slow', 0.2);
    })

    $('#close_register').click(function () {
        closeRegister();
        $('.super_container').fadeTo('slow', 1);
    });

    $('#toRegister').click(function () {
        closeLogin();
        showRegister();
    });

    $('#toLogin').click(function () {
        closeRegister();
        showLogin();
    })

    function closeLogin() {
        $("#loginform").fadeOut('slow');
        $("#loginform").css({ "visibility": "hidden", "display": "none" });
        
    }

    function showRegister() {
        $('#registerform').fadeIn('slow');
        $("#registerform").css({ "visibility": "visible", "display": "block" });
       
    }

    function closeRegister() {
        $("#registerform").fadeOut('slow');
        $("#registerform").css({ "visibility": "hidden", "display": "none" });
       
    }

    function showLogin() {
        $("#loginform").fadeIn('slow');
        $("#loginform").css({ "visibility": "visible", "display": "block" });
       
    }



   /* $('#register').submit(function () {
        var username = $('#registerform input[name=username]').val();
        var password = $('#registerform input[name=password]').val();
        var name = $('#registerform input[name=name]').val();
        var gender = $('#registerform input[name=gender]:checked').val();
        var email = $('#registerform input[name=email]').val();
        var phone = $('#registerform input[name=phone]').val();
        var address = $('#registerform input[name=address]').val();

        $.ajax({
            url: '/Account/Register',
            method: 'post',
            data: {
                username,
                password,
                name,
                gender,
                email,
                phone,
                address
            },
            success: function (result) {
                if (result === "UsernameExist") {
                    alert("Tên người dùng đã tồn tại");
                }
            }
        });
    });*/
});