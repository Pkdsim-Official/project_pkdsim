# PKDSIM developer tasks.
#
# The documentation site is built with DocFX. The C# API reference is generated
# from the PKDSIM/UnityAssets submodule, so the submodule must be checked out.

SUBMODULE := PKDSIM/UnityAssets
DOCFX     := docfx

.PHONY: help docs docs-serve docs-clean submodule

help: ## Show this help
	@grep -hE '^[a-zA-Z_-]+:.*?## ' $(MAKEFILE_LIST) | \
		awk 'BEGIN {FS = ":.*?## "} {printf "  %-14s %s\n", $$1, $$2}'

submodule: ## Ensure the UnityAssets submodule (the C# source) is checked out
	git submodule update --init --depth 1 $(SUBMODULE)

docs: submodule ## Build the documentation site into docs/_site
	@command -v $(DOCFX) >/dev/null 2>&1 || dotnet tool install -g docfx
	$(DOCFX) docs/docfx.json

docs-serve: submodule ## Build and serve the docs at http://localhost:8080
	@command -v $(DOCFX) >/dev/null 2>&1 || dotnet tool install -g docfx
	$(DOCFX) docs/docfx.json --serve

docs-clean: ## Remove generated docs artifacts
	rm -rf docs/_site docs/obj docs/api/*.yml docs/api/*.json docs/api/.manifest
