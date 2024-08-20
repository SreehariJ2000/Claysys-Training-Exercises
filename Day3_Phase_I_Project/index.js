

function validateFirstName() {
    const firstNameInput = document.getElementById("first-name");
    const firstname = firstNameInput.value.trim();
    const firstnameError = document.getElementById("firstNameError");

    if (firstname == '') {
        firstnameError.innerHTML = "Name field cannot be empty";
        updateBorder(firstNameInput, false);
    } else if (!/^[a-zA-Z\s]+$/.test(firstname)) {
        firstnameError.innerHTML = "Enter a valid name";
        updateBorder(firstNameInput, false);
    } else {
        firstnameError.innerHTML = '';
        updateBorder(firstNameInput, true);
    }
}

function validateLastName() {
    const lastNameInput = document.getElementById("last-name");
    const lastname = lastNameInput.value.trim();
    const lastNameError = document.getElementById("lastNameError");

    if (lastname == '') {
        lastNameError.innerHTML = "Lastname field cannot be empty";
        updateBorder(lastNameInput, false);
    } else if (!/^[a-zA-Z\s]+$/.test(lastname)) {
        lastNameError.innerHTML = "Enter a valid name";
        updateBorder(lastNameInput, false);
    } else {
        lastNameError.innerHTML = '';
        updateBorder(lastNameInput, true);
    }
}

function validateEmail() {
    const emailInput = document.getElementById("email");
    const email = emailInput.value.trim();
    const emailError = document.getElementById("emailError");
    const pattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if (email == '') {
        emailError.innerHTML = "Email field cannot be empty";
        updateBorder(emailInput, false);
    } else if (!pattern.test(email)) {
        emailError.innerHTML = "Enter a valid email";
        updateBorder(emailInput, false);
    } else {
        emailError.innerHTML = '';
        updateBorder(emailInput, true);
    }
}

function validatePhone() {
    const phoneInput = document.getElementById("phone");
    const phone = phoneInput.value.trim();
    const phoneError = document.getElementById("phoneError");
    const pattern = /^(?!(\d)\1{9})[6,7,8,9]\d{9}$/;

    if (phone == '') {
        phoneError.innerHTML = "Phone field cannot be empty";
        updateBorder(phoneInput, false);
    } else if (!pattern.test(phone)) {
        phoneError.innerHTML = "Enter a valid phone number";
        updateBorder(phoneInput, false);
    } else {
        phoneError.innerHTML = '';
        updateBorder(phoneInput, true);
    }
}

function validateAreaCode() {
    const areaCodeInput = document.getElementById("areacode");
    const areaCode = areaCodeInput.value.trim();
    const areaCodeError = document.getElementById("areaCodeError");
    const pattern = /^\+\d{1,3}$|^\d{1,3}$/;

    if (areaCode == '') {
        areaCodeError.innerHTML = "Area code field cannot be empty";
        updateBorder(areaCodeInput, false);
    } else if (!pattern.test(areaCode)) {
        areaCodeError.innerHTML = "Enter a valid area code";
        updateBorder(areaCodeInput, false);
    } else {
        areaCodeError.innerHTML = '';
        updateBorder(areaCodeInput, true);
    }
}

function validateStreetAddress() {
    const streetAddressInput = document.getElementById("street-address");
    const streetAddress = streetAddressInput.value.trim();
    const streetAddressError = document.getElementById("streetAddressError");

    if (streetAddress == '') {
        streetAddressError.innerHTML = "Street address field cannot be empty";
        updateBorder(streetAddressInput, false);
    } else if (!/^[a-zA-Z0-9\s,'-]+$/.test(streetAddress)) {
        streetAddressError.innerHTML = "Enter a valid street address";
        updateBorder(streetAddressInput, false);
    } else {
        streetAddressError.innerHTML = '';
        updateBorder(streetAddressInput, true);
    }
}

function validateCity() {
    const cityInput = document.getElementById("city");
    const city = cityInput.value.trim();
    const cityError = document.getElementById("cityError");

    if (city == '') {
        cityError.innerHTML = "City field cannot be empty";
        updateBorder(cityInput, false);
    } else if (!/^[a-zA-Z\s]+$/.test(city)) {
        cityError.innerHTML = "Enter a valid city name";
        updateBorder(cityInput, false);
    } else {
        cityError.innerHTML = '';
        updateBorder(cityInput, true);
    }
}

function validateState() {
    const stateInput = document.getElementById("state");
    const state = stateInput.value.trim();
    const stateError = document.getElementById("stateError");

    if (state == '') {
        stateError.innerHTML = "State field cannot be empty";
        updateBorder(stateInput, false);
    } else if (!/^[a-zA-Z\s]+$/.test(state)) {
        stateError.innerHTML = "Enter a valid state/province";
        updateBorder(stateInput, false);
    } else {
        stateError.innerHTML = '';
        updateBorder(stateInput, true);
    }
}

function validatePostalCode() {
    const postalCodeInput = document.getElementById("postal-code");
    const postalCode = postalCodeInput.value.trim();
    const postalCodeError = document.getElementById("postalCodeError");
    const pattern = /^[0-9]{5,10}$/;

    if (postalCode == '') {
        postalCodeError.innerHTML = "Postal code field cannot be empty";
        updateBorder(postalCodeInput, false);
    } else if (!pattern.test(postalCode)) {
        postalCodeError.innerHTML = "Enter a valid zip code (5-10 digits)";
        updateBorder(postalCodeInput, false);
    } else {
        postalCodeError.innerHTML = '';
        updateBorder(postalCodeInput, true);
    }
}

function validateCountry() {
    const countryInput = document.getElementById("country");
    const country = countryInput.value.trim();
    const countryError = document.getElementById("countryError");

    if (country == '') {
        countryError.innerHTML = "Country field cannot be empty";
        updateBorder(countryInput, false);
    } else if (!/^[a-zA-Z\s]+$/.test(country)) {
        countryError.innerHTML = "Enter a valid country name";
        updateBorder(countryInput, false);
    } else {
        countryError.innerHTML = '';
        updateBorder(countryInput, true);
    }
}

function validateAttendeeCount() {
    const attendeeCountInput = document.getElementById("attendee-count");
    const attendeeCount = attendeeCountInput.value.trim();
    const attendeeCountError = document.getElementById("attendeeCountError");

    if (attendeeCount == '') {
        attendeeCountError.innerHTML = "Attendee count field cannot be empty";
        updateBorder(attendeeCountInput, false);
    } else if (attendeeCount < 1 || attendeeCount > 10) {
        attendeeCountError.innerHTML = "Maximum 10 attendees are allowed";
        updateBorder(attendeeCountInput, false);
    } else {
        attendeeCountError.innerHTML = '';
        updateBorder(attendeeCountInput, true);
    }
}

function validateCompanyName() {
    const companyNameInput = document.getElementById("company-name");
    const companyName = companyNameInput.value.trim();
    const companyNameError = document.getElementById("companyNameError");

    if (companyName == '') {
        companyNameError.innerHTML = "Company name field cannot be empty";
        updateBorder(companyNameInput, false);
    } else if (companyName !== '' && ! /^(?=.*[a-zA-Z])[a-zA-Z0-9\s,'-]+$/.test(companyName)) {
        companyNameError.innerHTML = "Enter a valid company name";
        updateBorder(companyNameInput, false);
    } else {
        companyNameError.innerHTML = '';
        updateBorder(companyNameInput, true);
    }
}

function validateFullname() {
    const fullnameInput = document.getElementById("fullname");
    const name = fullnameInput.value.trim();
    const nameError = document.getElementById("nameError");

    if (name == '') {
        nameError.innerHTML = "Name field cannot be empty";
        updateBorder(fullnameInput, false);
    } else if (!/^[a-zA-Z\s]+$/.test(name)) {
        nameError.innerHTML = "Enter a valid name";
        updateBorder(fullnameInput, false);
    } else {
        nameError.innerHTML = '';
        updateBorder(fullnameInput, true);
    }
}

function validateSignature() {
    const signatureInput = document.getElementById("signature");
    const signature = signatureInput.value.trim();
    const signatureError = document.getElementById("signatureError");

    if (signature == '') {
        signatureError.innerHTML = "Signature field cannot be empty";
        updateBorder(signatureInput, false);
    } else if (!/^[a-zA-Z\s]+$/.test(signature)) {
        signatureError.innerHTML = "Enter a valid signature";
        updateBorder(signatureInput, false);
    } else {
        signatureError.innerHTML = '';
        updateBorder(signatureInput, true);
    }
}


function updateBorder(inputElement, isValid) {
    if (isValid) {
        inputElement.classList.add("border");
        inputElement.classList.remove("error-border");
    } else {
        inputElement.classList.add("error-border");
        inputElement.classList.remove("border");
    }
}
   
document.getElementById("registrationForm").addEventListener("submit",((e)=>{
    e.preventDefault(); 
    validateFirstName();
    validateLastName();
    validateEmail();
    validatePhone();
    validateAreaCode();
    validateStreetAddress();
    validateCity();
    validateState();
    validatePostalCode();
    validateCountry();
    validateAttendeeCount();
    validateCompanyName(); 
    validateFullname();
    validateSignature();
}))

//Date Vadalidation

var todayDate = new Date()
        var month =todayDate.getMonth() + 1   
        var year = todayDate.getFullYear()
        var tdate = todayDate.getDate()
        //console.log(tdate)
        if (month < 10) {
            month = "0" + month     
        }

        if (tdate < 10) {
            tdate = "0" + tdate     
        }
        var maxDate = year + "-" + month + "-" + tdate
        document.getElementById("date").setAttribute("min",maxDate)
        
