import React from "react";
import ContactPageLayout from "./ContactPageLayout";
export const AvailabilitySection = () => {
  return (
    <ContactPageLayout >
      <h2 className="text-2xl font-bold mb-4">Availability</h2>
      <p className="mb-4">I'm currently open to:</p>

      <ul className="space-y-4">
        {/* Full Stack Development */}
        <li className="flex items-center">
          <span className="text-lg mr-3">🚀</span>
          <div>
            <p className="font-bold">Full Stack Development</p>
            <p className="text-teal-300 text-sm">
              Building <strong>scalable web applications</strong> with
              <strong>React, .NET, and MySQL</strong>, focusing on modern UI/UX
              and backend efficiency.
            </p>
          </div>
        </li>

        {/* Scientific & Lab Automation Software */}
        <li className="flex items-center">
          <span className="text-lg mr-3">🔬</span>
          <div>
            <p className="font-bold">Scientific & Lab Automation Software</p>
            <p className="text-teal-300 text-sm">
              Developing <strong>React & .NET</strong> solutions for{" "}
              <strong>
                scientific research, lab automation, and real-time data
                processing
              </strong>
              .
            </p>
          </div>
        </li>
      </ul>
  
    </ContactPageLayout>
  );
};

export default AvailabilitySection;
