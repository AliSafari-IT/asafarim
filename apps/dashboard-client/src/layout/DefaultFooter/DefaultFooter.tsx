export function DefaultFooter() {
  return (
    <footer
      className="sticky bottom-0 w-full bg-gray-800 text-white py-4 text-center"
      style={{ position: 'fixed', left: 0, right: 0, bottom: 0 }}
    >
      <p className="text-sm">&copy; {new Date().getFullYear()} ASafariM. All Rights Reserved.</p>
    </footer>
  );
}

export default DefaultFooter;
