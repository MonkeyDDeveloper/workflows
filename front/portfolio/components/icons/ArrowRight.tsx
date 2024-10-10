import { motion } from 'framer-motion';

const ArrowRight = ({ className = '' }: { className?: string }) => {
    return (
        <motion.svg
            xmlns="http://www.w3.org/2000/svg"
            viewBox="-0.5 -0.5 16 16"
            height={24}
            width={24}
            className={className}
            fill="currentColor"
        >
            <g fill="none" fillRule="evenodd">
                <path
                    d="M15 0v15H0V0h15ZM7.87125 14.536249999999999l-0.0075 0.00125 -0.044375 0.021875000000000002 -0.0125 0.0025 -0.00875 -0.0025 -0.044375 -0.0225c-0.00625 -0.001875 -0.011875 0 -0.015 0.00375l-0.0025 0.00625 -0.010625 0.2675 0.003125 0.0125 0.00625 0.008125 0.065 0.04625 0.009375 0.0025 0.0075 -0.0025 0.065 -0.04625 0.0075 -0.01 0.0025 -0.010625 -0.010625 -0.266875c-0.00125 -0.00625 -0.005625 -0.010625 -0.01 -0.01125Zm0.165 -0.07062500000000001 -0.00875 0.00125 -0.11499999999999999 0.058124999999999996 -0.00625 0.00625 -0.001875 0.006874999999999999 0.01125 0.26875 0.003125 0.0075 0.005 0.005 0.12562500000000001 0.057499999999999996c0.0075 0.0025 0.014374999999999999 0 0.018125000000000002 -0.005l0.0025 -0.00875 -0.02125 -0.38375c-0.001875 -0.0075 -0.00625 -0.0125 -0.0125 -0.013749999999999998Zm-0.44687499999999997 0.00125a0.014374999999999999 0.014374999999999999 0 0 0 -0.016875 0.00375l-0.00375 0.00875 -0.02125 0.38375c0 0.0075 0.004375 0.0125 0.010625 0.015l0.009375 -0.00125 0.12562500000000001 -0.058124999999999996 0.00625 -0.005 0.001875 -0.006874999999999999 0.01125 -0.26875 -0.001875 -0.0075 -0.00625 -0.00625 -0.11499999999999999 -0.057499999999999996Z"
                    strokeWidth="1"
                />
                <path
                    fill="currentColor"
                    d="M3.933125 3.933125a0.625 0.625 0 0 1 0.8837499999999999 0l3.125 3.125a0.625 0.625 0 0 1 0 0.8837499999999999l-3.125 3.125a0.625 0.625 0 0 1 -0.8837499999999999 -0.8837499999999999L6.61625 7.5 3.933125 4.816875a0.625 0.625 0 0 1 0 -0.8837499999999999Zm3.75 0a0.625 0.625 0 0 1 0.8837499999999999 0l3.125 3.125a0.625 0.625 0 0 1 0 0.8837499999999999l-3.125 3.125a0.625 0.625 0 0 1 -0.8837499999999999 -0.8837499999999999L10.366249999999999 7.5l-2.683125 -2.683125a0.625 0.625 0 0 1 0 -0.8837499999999999Z"
                    strokeWidth="1"
                />
            </g>
        </motion.svg>
    );
};

export default ArrowRight;
