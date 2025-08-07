import React from 'react';

const BlogDetails = () => {
  const blogs = [
    { id: 1, title: 'React State vs Props' },
    { id: 2, title: 'Understanding Virtual DOM' },
    { id: 3, title: 'Conditional Rendering Tricks' }
  ];

  return (
    <div>
      <h2>📝 Blog Details</h2>
      <ul>
        {blogs.map(blog => (
          <li key={blog.id}>{blog.title}</li>
        ))}
      </ul>
    </div>
  );
};

export default BlogDetails;
