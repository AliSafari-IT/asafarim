import { useState } from 'react'
import { Routes, Route } from 'react-router-dom'
import BookList from './components/BookList'
import BookDetails from './components/BookDetails'
import './App.css'
import Navbar from './layout/Navbar'
import BookForm from './components/BookForm'
import AppInfo from './components/AppInfo'
import './components/AppInfo.css'

function App() {
  const [selectedBookId, setSelectedBookId] = useState<string | null>(null)

  return (
    <div className="app-container">
      <Navbar />
      <main className="main-content">
        <Routes>
          <Route path="/" element={
            <div className="bibliography-container">
              <div className="book-list-container">
                <BookList onSelectBook={setSelectedBookId} />
              </div>
              <div className="book-details-container">
                {selectedBookId ? (
                  <BookDetails bookId={selectedBookId} />
                ) : (
                  <div className="empty-state">
                    <h2>Select a book to view details</h2>
                    <p>Click on any book from the list to view its details</p>
                  </div>
                )}
              </div>
              <div className="app-info-wrapper">
                <AppInfo />
              </div>
            </div>
          } />
          <Route path="/add" element={<BookForm />} />
        </Routes>
      </main>
      <footer className="app-footer">
        <p> {new Date().getFullYear()} ASafariM Bibliography</p>
      </footer>
    </div>
  )
}

export default App
