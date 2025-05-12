import { defineWorkspace } from 'vitest/config'

export default defineWorkspace([
  "./vitest.config.ts",
  "./ASafariM.Clients/asafarim-ui/vitest.config.ts",
  "./ASafariM.Clients/asafarim-blog/vitest.config.ts",
  "./ASafariM.Clients/asafarim-bibliography/vitest.config.ts"
])
