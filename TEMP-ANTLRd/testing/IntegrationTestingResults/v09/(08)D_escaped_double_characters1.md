========================================
Source Code (between the arrows)
========================================

🡆fa brics <6O4fovPJ>->

    wool fabrics <cTk1qeGz>,
    cotton fabrics \[[https://www.notube.com/watch?v=hTui12lKus]<evssLum4>,
    silk \[https://www.notube.com/watch?v=hTui12lKus\]fabrics<WR31xpLW>,
    synthetic fabrics <sfObQkOm>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fa brics ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'6O4fovPJ')
│   │       └── T(RIGHT_ARROW|'>')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'cTk1qeGz')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'evssLum4')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_LEFT_SQUARE|'\[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'https:')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(FORWARD_SLASHES|'//')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'www.notube.com')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(FORWARD_SLASH|'/')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'watch?v=hTui12lKus')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_RIGHT_SQUARE|'\]')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'WR31xpLW')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'sfObQkOm')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')