function showSignupForm() {
    let signinFormIsHidden = document.getElementById("signin-form-container").classList.contains("d-none");
    if (signinFormIsHidden) {
        document.getElementById("signup-form-container").classList.remove("d-none");
    } else {
        document.getElementById("signin-form-container").classList.toggle("d-none");
        document.getElementById("signup-form-container").classList.remove("d-none");
    }
}

function showSigninForm() {
    let signupFormIsHidden = document.getElementById("signup-form-container").classList.contains("d-none");
    if (signupFormIsHidden) {
        document.getElementById("signin-form-container").classList.remove("d-none");
    } else {
        document.getElementById("signup-form-container").classList.toggle("d-none");
        document.getElementById("signin-form-container").classList.remove("d-none");
    }
}