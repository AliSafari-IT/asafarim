import React from "react";

function ScrollingButtons() {
    const scrollToTop = () => window.scrollTo({ top: 0, behavior: 'smooth' });
    const scrollToBottom = () => window.scrollTo({ top: document.body.scrollHeight, behavior: 'smooth' });

    return (
        <div className="scroll-buttons flex flex-col gap-2">
        <button onClick={scrollToTop} className="btn-primary">⬆</button>
        <button onClick={scrollToBottom} className="btn-secondary">⬇</button>
      </div>
    );
}

export default ScrollingButtons;
