import React from 'react';

const BookDetails = () => {
  const books = [
    { id: 1, title: 'React Basics', author: 'Dan Abramov' },
    { id: 2, title: 'Learning JSX', author: 'Sophie Alpert' },
    { id: 3, title: 'React Hooks in Depth', author: 'Brian Vaughn' }
  ];

  return (
    <div>
      <h2>📘 Book Details</h2>
      <ul>
        {books.map(book => (
          <li key={book.id}>
            <strong>{book.title}</strong> - {book.author}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default BookDetails;
