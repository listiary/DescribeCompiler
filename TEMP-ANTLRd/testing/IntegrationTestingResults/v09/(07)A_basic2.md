========================================
Source Code (between the arrows)
========================================

🡆fabrics -> 
	
	synthetic fabrics <i1NLckN6>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabrics ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'> \r\n\t\r\n\t')
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'synthetic fabrics ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'i1NLckN6')
│   │       └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')