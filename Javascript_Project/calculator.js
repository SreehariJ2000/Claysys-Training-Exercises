function addItem(item) {
    const data = document.getElementById("display")
    data.value += item
    
 }
 function clearDisplay() {
     document.getElementById("display").value = ''
 }

 function calculateResult() {
     const data = document.getElementById("display")
     data.value = eval(display.value);
 }