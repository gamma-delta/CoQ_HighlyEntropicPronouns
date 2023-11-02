#!/usr/bin/env janet

(use cbt)
(use cbt/xml-helpers/objects)

(build-metadata
  :qud-dlls "/home/petrak/.local/share/Steam/steamapps/common/Caves of Qud/CoQ_Data/Managed/"
  :qud-mods-folder "/home/petrak/.config/unity3d/Freehold Games/CavesOfQud/Mods/")

(declare-mod
  "highly-entropic-pronouns"
  "{{otherpearl|Highly Entropic Pronouns}}"
  "petrak@"
  "0.1.0"
  :description "Makes highly entropic beings give a random pronoun every time they're queried."
  :thumbnail "thumbnail.png"
  :steam-id 3069197069)

# (set-debug-output true)

