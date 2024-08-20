function validateName(){
    const name = document.getElementById("name").value.trim();
    if (name =='') {
        document.getElementById("nameError").innerHTML = "Name field cannot be empty"
    } else if (!/^[a-zA-Z\s]+$/.test(name)) {
        document.getElementById("nameError").innerHTML = "Enter a valid name";
    } else {
        document.getElementById("nameError").innerHTML = '';
    }
}

function validateEmail(){
    const email = document.getElementById("email").value.trim();
    const Pattern= /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    if (email == ''){
        document.getElementById("emailError").innerHTML = "Email field cannot be empty";
    } else if (!Pattern.test(email)){
        document.getElementById("emailError").innerHTML = "Enter a valid email";
    }
    else{
        document.getElementById("emailError").innerHTML = '';
    }
}

function validatePhone(){
    const phone = document.getElementById("phone").value.trim();
     const Pattern =  /^(?!(\d)\1{9})[6,7,8,9]\d{9}$/;

     if (phone == '') {
        document.getElementById("phoneError").innerHTML = "Phone field cannot be empty"
     }
     else if (!Pattern.test(phone)){
        document.getElementById("phoneError").innerHTML = "Enter a valid phone number";
     }
     else{
        document.getElementById("phoneError").innerHTML = '';
     }    
}

function validateMessage(){
    const message = document.getElementById("message").value.trim();
    if (message == '') {
        document.getElementById("messageError").innerHTML = "Message field cannot be empty";
    }else{
        document.getElementById("messageError").innerHTML = '';
    }
}


document.getElementById("contact-form").addEventListener("submit", function(e){
    e.preventDefault();
    validateName();
    validateEmail();
    validatePhone();
    validateMessage();
})
