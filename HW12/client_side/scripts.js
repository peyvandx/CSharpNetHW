// SignIn Page
// $('.message a').click(function(){
//    $('form').animate({height: "toggle", opacity: "toggle"}, "slow");
// });
// End Of SignIn Page

// SignUp Page
function CallSignUpAPI() {

   const apiURL = "https://localhost:7202/api/Authentication/Signup";
   const formData = new FormData(document.getElementById("signup-form"));

   fetch(apiURL, {
      method : "POST",
      body: formData,
   })
   .then(function (response)
   {
      // console.log (response.status);
      if (response.ok) {
         alert("You're Signed Up SuccessFully");
      } else {
         alert("Error With Sign You Up. ", response.status);
      }
      return response.json();
   })
   .then((data) => {
      console.log("Success", data);
   })
   .catch((error) => {
      console.log("Error on fetch", error);
   })
}

// End Of SignUp Page

// SignIn Page
function CallSignInAPI() {

   const apiURL = "https://localhost:7202/api/Authentication/Signin";
   const formData = new FormData(document.getElementById("signin-form"));

   fetch(apiURL, {
      method: "POST",
      body: formData,
   })
   .then(function (response) {
      if (response.ok) {
         alert("You're Loged In Successfully");
         // document.getElementById("go-to-user-management-page")
         window.location.href = "./users_management.html";
      } else {
         alert("Incorrect email or password");
      }
      return response.json();
   })
   .then((data) => {
      console.log("Success", data);
   })
   .catch((error) => {
      console.log("Error on fetch", error.message);
   })
}
// End Of SignIn Page

// Users Management Page

// End Of Users Management Page