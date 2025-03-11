import Layout from "@/layout/Layout";
import AvailabilitySection from "./components/AvailabilitySection";
import ContactInfo from "./components/ContactInfo";
import FutureSkillsSection from "./components/FutureSkillsSection";
import ContactForm from "./components/ContactForm";

export const ContactUs = () => {
 
  return (
    <Layout
      pageTitle={"Contact Us"}
      pageDescription={"Contact Us Page Description"}
    >
      <div className="max-w-7xl mx-auto px-4 py-12">
        {/* Page Header - Hero Section */}
        <div className="text-center mb-16">
          <h1 className="text-5xl font-bold text-gray-800 dark:text-white mb-6">
            <span className="bg-gradient-to-r from-teal-500 to-blue-500 bg-clip-text text-transparent">
              Get In Touch
            </span>
          </h1>
          <p className="text-xl text-gray-600 dark:text-gray-300 max-w-2xl mx-auto">
            I'm always interested in new opportunities and collaborations. Feel
            free to reach out through any of the channels below.
          </p>
        </div>

        {/* Main Content Layout */}
        <div className="flex flex-col lg:flex-row gap-8">
          {/* Left Column - Contact Info & Form */}
          <div className="lg:w-2/3">
            {/* Contact Info Card - Prominent placement */}
            <div className="bg-white dark:bg-gray-800 rounded-2xl shadow-xl overflow-hidden mb-8 transform transition-all duration-300 hover:shadow-2xl">
              <div className="p-6">
                <ContactInfo />
              </div>
            </div>
            
            {/* Contact Form Card - Just below contact info */}
            <div className="bg-white dark:bg-gray-800 rounded-2xl shadow-xl overflow-hidden transform transition-all duration-300 hover:shadow-2xl">
              <div className="p-6">
                <ContactForm />
              </div>
            </div>
          </div>
          
          {/* Right Column - Availability & Future Skills */}
          <div className="lg:w-1/3">
            <div className="sticky top-8">
              {/* Availability Section - With visual enhancement */}
              <div className="bg-gradient-to-r from-teal-500 to-blue-600 rounded-2xl shadow-xl overflow-hidden mb-8 transform transition-all duration-300 hover:scale-[1.02]">
                <div className="p-6 text-white">
                  <AvailabilitySection />
                </div>
              </div>
              
              {/* Future Skills Section - With complementary styling */}
              <div className="bg-white dark:bg-gray-800 rounded-2xl shadow-xl overflow-hidden border border-blue-200 dark:border-blue-900 transform transition-all duration-300 hover:scale-[1.02]">
                <div className="p-6">
                  <FutureSkillsSection />
                </div>
              </div>
              
              {/* Dutch Message - Stylized at the bottom */}
              <div className="mt-8 p-4 bg-teal-50 dark:bg-teal-900/30 rounded-xl border-l-4 border-teal-500">
                <p className="text-sm text-teal-700 dark:text-teal-300 italic">
                  "Ik ben altijd geïnteresseerd in nieuwe kansen en samenwerkingen."
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </Layout>
  );
};

export default ContactUs;
