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
window.addEventListener("load", function () {
   const apiURL = "https://localhost:7202/api/CRUD/GetAllUsers";

   fetch(apiURL)
   .then((response) => response.json())
   .then(function (data) {
      console.log(data);
      data.forEach((element) => {
         let tr = document.createElement("tr");
         let th = document.createElement("th");
         let input = document.createElement("input");
         input.className = "form-check-input";
         input.type = "checkbox";
         th.scope = "row";
         th.appendChild(input);
         let first_td = document.createElement("td");
         first_td.innerText = element.firstName;
         let second_td = document.createElement("td");
         second_td.innerText = element.lastName;
         let third_td = document.createElement("td");
         third_td.innerText = element.email;
         tr.appendChild(th);
         tr.appendChild(first_td);
         tr.appendChild(second_td);
         tr.appendChild(third_td);
         document.getElementById("table-body").appendChild(tr);
      });
   })
});
// End Of Users Management Page