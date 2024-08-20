document.getElementById("movie-form").addEventListener("submit",((e)=>{
    e.preventDefault();
    addData();
}));


function addData(){
    let movie = document.getElementById("movie").value.trim();
    let director = document.getElementById("director").value.trim();
    let rating = document.getElementById("rating").value.trim();

    if (movie=='' || director=='' || rating == '') {
        return alert("enter valid data")
    }

    const movieObject = {
              movie : movie ,
              director : director ,
              rating : rating ,
             }
    let movies = JSON.parse(localStorage.getItem('movieDetails')) || [];
     movies.push(movieObject);
     localStorage.setItem('movieDetails', JSON.stringify(movies));
     DisplayDetails();
}

function DisplayDetails(){
    let movies = JSON.parse(localStorage.getItem('movieDetails'));
   // console.log(movies)
    let movieListHtml = '';

    movies.forEach(movie => {
        movieListHtml +=   `<li> Movie ${movie.movie} directed by ${movie.director} has rating ${movie.rating} </li>`
    });

    document.getElementById("Movie-list").innerHTML = movieListHtml;
}


window.onload = function() {
    DisplayDetails();
};