const seats = document.querySelector(".select-seat")

$(document).ready(function () {
    $(".trigger").addClass("drawn")
});


seats.addEventListener("click", (e) => {
    if (e.target.classList.contains("seat") && !e.target.classList.contains("reserved") && !e.target.classList.contains("seat-pre")) {
        e.target.classList.toggle("reserved")
        console.log(e.target)
    }
})


