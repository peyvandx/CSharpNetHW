// SignIn Page
// $('.message a').click(function(){
//    $('form').animate({height: "toggle", opacity: "toggle"}, "slow");
// });
// End Of SignIn Page

// SignUp Page
function CallSignUpAPI(){

   const apiURL = "https://localhost:7202/api/Authentication/Signup";
   const formData = new FormData(document.getElementById("signup-form"))

   fetch(apiURL, {
      method : "POST",
      body: formData
   }).then((response) => response.json())
   .then((data) => {
      console.log("Success", data)
   })
   .catch((error) => {
      console.log("Error on fetch", error)
   })
}
// End Of SignUp Page