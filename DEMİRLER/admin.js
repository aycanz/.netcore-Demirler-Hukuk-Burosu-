 

// Blog ekleme formunu a�ma
function showAddForm() {
    document.getElementById('blogForm').style.display = 'block';
}

// Blog ekleme formunu kapatma
function cancelEdit() {
    document.getElementById('blogForm').style.display = 'none';
}

function editBlog(blogId) {
    window.location.href = "/Blog/Edit/" + blogId;
}

function deleteBlog(blogId) {
    if (confirm("Bu blogu silmek istedi�inize emin misiniz?")) {
        window.location.href = "/Blog/Delete/" + blogId;
    }
}

function showAddForm() {
    console.log("Yeni yaz� ekleme formu a��l�yor...");
    document.getElementById('blogForm').style.display = 'block';
}

 
 