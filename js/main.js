// Start FaQs
let collapseButton = document.querySelectorAll(".card-header button");
collapseButton.forEach((btn) => {
    btn.addEventListener("click", () => {
        if (btn.getAttribute("aria-expanded") === "true") {
            btn.firstElementChild.lastElementChild.firstElementChild.src = ("../assets/icons/arrow-down.svg");
        } else {
            btn.firstElementChild.lastElementChild.firstElementChild.src = ("../assets/icons/arrow-up.svg");
        }
    })
})

//Get Scootin Button
let getScootin = document.querySelector(".Scootin-button");
getScootin.addEventListener("click", () => {
    document.querySelector(".sign-up").scrollIntoView({behavior: "smooth"});
});

//Start Applies Buttons
let applyButtons = document.querySelectorAll(".apply-button");
applyButtons.forEach((btn) => {
    btn.addEventListener("click", () => {
        applyButtons.forEach((btn) => {
            btn.classList.remove("active");
        })
        btn.classList.add("active");
        document.querySelector(".navbar").scrollIntoView({behavior: "smooth"});
    })
})



