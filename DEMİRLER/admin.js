 

// Blog ekleme formunu açma
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
    if (confirm("Bu blogu silmek istediðinize emin misiniz?")) {
        window.location.href = "/Blog/Delete/" + blogId;
    }
}

function showAddForm() {
    console.log("Yeni yazý ekleme formu açýlýyor...");
    document.getElementById('blogForm').style.display = 'block';
}

 
 