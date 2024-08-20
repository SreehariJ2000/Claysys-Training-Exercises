document.getElementById("todo-form").addEventListener("submit",((e)=>{
    e.preventDefault();
    addTask();         
}))


function addTask(){
let task = document.getElementById("todo-task").value.trim();
if (task == '') {
    return alert("please enter the task")          
}
const taskArray = JSON.parse(localStorage.getItem('Tasks')) || [];
taskArray.push({id : Date.now(), task:task , done:false});
localStorage.setItem('Tasks', JSON.stringify(taskArray));
document.getElementById("todo-task").value = '';
displayTask();
}


function displayTask(){
const taskArray = JSON.parse(localStorage.getItem('Tasks')) || [];
const container = document.getElementById('items');
container.innerHTML = '';
taskArray.forEach(task => {
    const Parentdiv = document.createElement('div')
    Parentdiv.classList.add('todo-item')
    const checkbox = document.createElement('input')
    checkbox.type = 'checkbox'
    checkbox.checked = task.done
    const paragraph = document.createElement('p')
    paragraph.textContent = task.task
    if (task.done) {
    paragraph.style.textDecoration = 'line-through';
    }
    const icon =  document.createElement('i')
    icon.classList.add('material-icons')
    icon.textContent = 'delete'
    icon.addEventListener('click',(()=>{
        deleteTask(task.id)
    }))

    checkbox.addEventListener('change', () => {
    updateTask(task.id, checkbox.checked);
         });
    Parentdiv.appendChild(checkbox)
    Parentdiv.appendChild(paragraph)
    Parentdiv.appendChild(icon)
    container.appendChild(Parentdiv)
});
}

function deleteTask(id){
//console.log(id)
const taskArray = JSON.parse(localStorage.getItem('Tasks')) || [];
const newTask = taskArray.filter((task)=>{
    return task.id != id
})
localStorage.setItem('Tasks', JSON.stringify(newTask));
displayTask();
}


function updateTask(id, checked) {
const taskArray = JSON.parse(localStorage.getItem('Tasks')) || [];
const updatedTasks = taskArray.map(task => {
if (task.id === id) {
    return { ...task, done: checked };
}
return task;
 });
localStorage.setItem('Tasks', JSON.stringify(updatedTasks));
displayTask();
}


displayTask();