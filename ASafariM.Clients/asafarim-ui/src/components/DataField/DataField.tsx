// src/components/DataField/DataField.tsx
import { Text } from "@fluentui/react-components";

const DataField: React.FC<{
  label: string;
  value?: string | number | null;
  fallback?: string;
}> = ({ label, value, fallback = "N/A" }) => (
  <div className="mb-4">
    <Text weight="semibold" className="block mb-1">{label}:</Text>
    <Text>{value?.toString() || fallback}</Text>
  </div>
);

export default DataField;