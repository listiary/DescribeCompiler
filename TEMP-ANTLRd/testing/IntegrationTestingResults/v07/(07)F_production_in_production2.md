========================================
Source Code (between the arrows)
========================================

🡆macronutrients <eQxYylc3> ->

    water <tdgS8qBO>,
	fiber <OpdFntBx> ->

        what <MLUxjdg8>,
        not <qkVgxZIs>;;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients <eQxYylc3')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water <tdgS8qBO')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'fiber <OpdFntBx')
│   │       │   └── text_chunk
│   │       │       └── T(RIGHT_ARROW|'> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(RIGHT_ARROW|'>\r\n\r\n        ')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'what <MLUxjdg8')
│   │       │   │   │   └── text_chunk
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │       │   └── item
│   │       │       ├── text_chunk
│   │       │       │   └── T(DATA|'not <qkVgxZIs')
│   │       │       └── text_chunk
│   │       │           └── T(RIGHT_ARROW|'>')
│   │       └── T(TERMINATOR|';')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')