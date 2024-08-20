async function fetchPosts() {
    try {
        const response = await fetch('https://jsonplaceholder.typicode.com/posts');
        console.log(response)
        const posts = await response.json();
       
        displayPosts(posts);
    } catch (error) {
        console.error('Error fetching posts:', error);

    }
}

function displayPosts(posts) {
    posts.forEach(post => {
        console.log(`Title: ${post.title}`);
    });
}

document.getElementById('fetchPosts').addEventListener('click', fetchPosts);