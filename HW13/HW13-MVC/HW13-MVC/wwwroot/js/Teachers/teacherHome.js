function myCourses(signedInTeacher) {
    let columnDiv = document.createElement("div").classList.add("col");
    let cardDiv = document.createElement("div").classList.add("card mb-5");
    cardDiv.style.width = "18rem";
    let cardBodyDiv = document.createElement("div").classList.add("card-body");
    let cardTitle = document.createElement("h5").classList.add("card-title");
    cardTitle.innerText = signedInTeacher.
}