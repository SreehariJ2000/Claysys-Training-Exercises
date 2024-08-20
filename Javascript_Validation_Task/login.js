function validateUsername() {
    let usernameInput = document.getElementById("username");
    let username = usernameInput.value.trim();

    if (username === '') {
        setError(usernameInput, "Username field is empty");
    } else if (!/^[a-zA-Z\s]+$/.test(username)) {
        setError(usernameInput, "Enter a valid username");
    } else {
        setSuccess(usernameInput);
    }
}

function validatePassword() {
    let passwordInput = document.getElementById("password");
    let password = passwordInput.value.trim();

    if (password === '') {
        setError(passwordInput, "Password field is empty");
    } else if (password.length < 6) {
        setError(passwordInput, "Password must be at least 6 characters long");
    } else {
        setSuccess(passwordInput);
    }
}

function setError(input, message) {
    let parent = input.parentElement;
    let span = parent.querySelector('span');
    span.className = 'error';
    span.innerText = message;
}

function setSuccess(input) {
    let parent = input.parentElement;
    let span = parent.querySelector('span');
    span.className = 'correct';
    span.innerText = '';
}



document.getElementById("loginForm").addEventListener("submit",((e)=>{
    e.preventDefault();
    validateUsername();
    validatePassword();
}))